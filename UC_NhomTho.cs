using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DeTai
{
    public partial class UC_NhomTho : UserControl, IController
    {
        SCXMdbDataContext db = new SCXMdbDataContext();
        NhomThoe nhomtho;
        bool f_update = false;
        bool f_candelete = false;

        public UC_NhomTho()
        {
            InitializeComponent();
        }

        public UC_NhomTho(string id)
        {
            InitializeComponent(); 
            f_update = true;
            nhomtho = db.NhomThoes.Single(p => p.MaNhom == id);
            txtMa.Enabled = false;
        }

        private void UC_NhomTho_Load(object sender, EventArgs e)
        {
            var thos = from p in db.NhanViens
                       where p.deleted == false
                       select p;
            NhomTruongBindingSource.DataSource = thos;

            nhanVienBindingSource.DataSource = thos;

            if (f_update == true)
                load();
        }

        public void save()
        {
            if (checkData() == false)
                return;
            if (f_update == false)
                insert();
            else
                update();

        }
        private void insert()
        {
            nhomtho = new NhomThoe();
            nhomtho.MaNhom = txtMa.Text;
            nhomtho.TenNhom = txtFullName.Text;
            nhomtho.deleted = false;

            NhanVien nhomtruong = lookNhomTruong.GetSelectedDataRow() as NhanVien;
            nhomtho.NhanVien = nhomtruong;
            
            // List thanh vien
            int i = 0;
            while(i < gridViewThanhVien.RowCount)
            {
                Tho_Nhom thonhom = gridViewThanhVien.GetRow(i) as Tho_Nhom;

                if (thonhom == null)
                {
                    return;
                }
                
                String matho = null;
                try
                {
                    matho = gridViewThanhVien.GetRowCellValue(i, colMaTho).ToString();
                }
                catch (Exception ex)
                {
                }

                if (matho == null)
                {
                    gridViewThanhVien.DeleteRow(i);
                    continue;
                }

                thonhom.deleted = false;
                thonhom.NhomThoe = nhomtho;

                String temp = null;
                int j = 0;
                bool f = false;

                // kiểm tra 1 thợ add nhiều lần
                // duyệt từ đầu để kiểm tra
                while (j < i)
                {
                    temp = gridViewThanhVien.GetRowCellValue(j, colMaTho).ToString();
                    if (thonhom.MaTho == temp)
                    {
                        gridViewThanhVien.DeleteRow(i);
                        f = true;
                        break;
                    }
                    j++;
                }

                if (f == true)
                    continue;

                i++;
            }

            db.NhomThoes.InsertOnSubmit(nhomtho);
            db.SubmitChanges();

            MessageBox.Show("Success!", "Message", MessageBoxButtons.OK);
            f_update = true;
        }

        private void update()
        {
            try
            {
                nhomtho.TenNhom = txtFullName.Text;

                NhanVien nhomtruong = lookNhomTruong.GetSelectedDataRow() as NhanVien;
                nhomtho.NhanVien = nhomtruong;

                int i = 0;
                while (i < gridViewThanhVien.RowCount)
                {
                    Tho_Nhom thonhom = gridViewThanhVien.GetRow(i) as Tho_Nhom;

                    if (thonhom == null)
                    {
                        return;
                    }

                    String matho = null;
                    try
                    {
                        matho = gridViewThanhVien.GetRowCellValue(i, colMaTho).ToString();
                    }
                    catch (Exception ex)
                    { }

                    // Khong cho sua
                    if (matho == null)
                    {
                        MessageBox.Show("Trường thợ không được rỗng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (thonhom.deleted == true)
                    {
                        if (f_candelete == false)
                        {
                            FormAuthenDelete frmAuthen = new FormAuthenDelete();
                            DialogResult result = frmAuthen.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                thonhom.deleted = true;
                                f_candelete = true;
                                i++;
                                continue;
                            }
                            else
                            {
                                MessageBox.Show("Sai mật khẩu");
                                return;
                            }
                        }
                        else
                        {
                            i++;
                            continue;
                        }
                    }

                    String temp = null;
                    int j = 0;
                    bool f = false;
                    while (j < i)
                    {
                        temp = gridViewThanhVien.GetRowCellValue(j, colMaTho).ToString();
                        if (thonhom.MaTho == temp)
                        {
                            gridViewThanhVien.DeleteRow(i);
                            f = true;
                            break;
                        }
                        j++;
                    }
                    if (f == true)
                        continue;

                    // Thêm công việc đã tồn tại bị xóa
                    try
                    {
                        Tho_Nhom check = db.Tho_Nhoms.Single(p => p.MaTho == matho && p.deleted == true);
                        check.deleted = false;
                        gridViewThanhVien.DeleteRow(i);
                        continue;
                    }
                    catch (Exception ex)
                    {
                        thonhom.NhomThoe = nhomtho;
                    }

                    i++;
                }

                db.SubmitChanges();
                MessageBox.Show("Success!", "Message", MessageBoxButtons.OK);
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail!", "Message", MessageBoxButtons.OK);
            }
            f_candelete = false;
        }

        public void load()
        {
            txtMa.Text = nhomtho.MaNhom;
            txtFullName.Text = nhomtho.TenNhom;
            lookNhomTruong.DataBindings.Control.Text = nhomtho.NhanVien.TenNV;
            
            var thanhviens = from p in db.Tho_Nhoms
                             where p.deleted == false && p.NhomThoe == nhomtho
                             select p;
            thoNhomsBindingSource.DataSource = thanhviens;
        }

        public void Dispose()
        {
            if (f_update == false)
            {
                txtFullName.ResetText();
                txtMa.ResetText();
                thoNhomsBindingSource.Dispose();
                gridThanhVien.RefreshDataSource();
            }
            else
                load();
        }

        private bool checkData()
        {
            bool result = true;
            Check check = new Check();

            result = check.checkEmpty(txtFullName) && result;
            result = check.checkEmpty(txtMa) && result;
            result = check.checkEmpty(lookNhomTruong) && result;

            return result;
        }

        private void texbox_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void btnCheckMaNhom_Click(object sender, EventArgs e)
        {
            try
            {
                NhomThoe nhom = db.NhomThoes.Single(p => p.MaNhom == txtMa.Text);
                MessageBox.Show("Mã đã tồn tại", "Fail", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã có thể dùng", "Success", MessageBoxButtons.OK);
            }
        }

        private void btnAddCongViec_Click(object sender, EventArgs e)
        {
            gridViewThanhVien.AddNewRow();
        }
    }
}
