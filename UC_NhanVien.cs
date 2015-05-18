using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DeTai
{
    public partial class UC_NhanVien : UserControl, IController
    {
        SCXMdbDataContext db = new SCXMdbDataContext();
        NhanVien nhanvien;
        NhomThoe nhomtho = null;
        Tho_Nhom thanhviennhom = null;
        bool f_update = false;
        bool f_candelete = false;

        public UC_NhanVien()
        {
            InitializeComponent();
        }

        public UC_NhanVien(String id)
        {
            InitializeComponent();
            
            nhanvien = db.NhanViens.Single(p => p.MaNV == id);
            thanhviennhom = db.Tho_Nhoms.OrderBy(e => e.MaNhom).FirstOrDefault(e => e.MaTho == id);
            if (thanhviennhom != null)
                nhomtho = thanhviennhom.NhomThoe;
            f_update = true;
        }

        public void save()
        {
            if (!checkData())
                return;

            if (f_update == true)
            {
                update();
            }
            else
            {
                insert();
                clear();
            }
        }

        private void insert()
        {
            try
            {
                nhanvien = new NhanVien();
                nhanvien.TenNV = txtFullName.Text;
                nhanvien.SDT = txtPhoneNum.Text;
                nhanvien.NamSinh = DateTime.Parse(txtNamSinh.Text);
                nhanvien.DiaChi = txtAddress.Text;
                nhanvien.Luong = Double.Parse(txtLuong.Text);
                nhanvien.deleted = false;
                nhanvien.GioiTinh = rdoGioiTinh.SelectedIndex == 1;
                nhanvien.MaNV = txtPhoneNum.Text + "-" + nhanvien.NamSinh;

                LoaiNV lnv = lookChucVu.GetSelectedDataRow() as LoaiNV;
                if (lnv != null)
                {
                    nhanvien.LoaiNV = lnv;
                }
                else
                    nhanvien.LoaiNV = null;

                nhomtho = (NhomThoe)lookNhom.GetSelectedDataRow();
                if (nhomtho != null)
                {
                    Tho_Nhom tho_nhom = new Tho_Nhom();
                    tho_nhom.NhomThoe = nhomtho;
                    tho_nhom.NhanVien = nhanvien;
                    tho_nhom.deleted = false;
                }

                // Get CongViec
                int i = 0;
                while (i < gridView.RowCount)
                {
                    MucDoThanhThao mucdothanhthao = gridView.GetRow(i) as MucDoThanhThao;
                    if (mucdothanhthao == null)
                    {
                        i++;
                        break;
                    }

                    String maCV = null;
                    int mucdo = 0;
                    try
                    {
                        maCV = gridView.GetRowCellValue(i, colMaCV).ToString();
                        mucdo = Int16.Parse(gridView.GetRowCellValue(i, colMucDo).ToString());
                    }
                    catch (Exception) { }

                    if (maCV == null)
                    {
                        gridView.DeleteRow(i);
                        continue;
                    }

                    String temp = null;
                    int j = 0;
                    bool f = false;
                    while (j < i)
                    {
                        temp = gridView.GetRowCellValue(j, colMaCV).ToString();
                        if (maCV == temp)
                        {
                            gridView.DeleteRow(i);
                            f = true;
                            break;
                        }
                        j++;
                    }
                    if (f == true)
                        continue;

                    mucdothanhthao.MaCV = maCV;
                    mucdothanhthao.MucDo = mucdo;
                    mucdothanhthao.NhanVien = nhanvien;
                    mucdothanhthao.deleted = false;

                    i++;
                }

                db.NhanViens.InsertOnSubmit(nhanvien);
                db.SubmitChanges();
                f_update = true;

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex) {
                MessageBox.Show("Fail", "Fail", MessageBoxButtons.OK);
            }
        }

        private void update()
        {
            //try
            //{
                nhanvien.TenNV = txtFullName.Text;
                nhanvien.SDT = txtPhoneNum.Text;
                nhanvien.NamSinh = DateTime.Parse(txtNamSinh.Text);
                nhanvien.DiaChi = txtAddress.Text;
                nhanvien.Luong = Double.Parse(txtLuong.Text);
                nhanvien.GioiTinh = rdoGioiTinh.SelectedIndex == 1;

                LoaiNV lnv = lookChucVu.GetSelectedDataRow() as LoaiNV;
                nhanvien.LoaiNV = lnv;

                NhomThoe newNhomTho = (NhomThoe)lookNhom.GetSelectedDataRow();
                if (nhomtho != newNhomTho)
                {
                    thanhviennhom.deleted = true;
                    try
                    {
                        Tho_Nhom old = db.Tho_Nhoms.Single(p => p.deleted == true && p.NhanVien == nhanvien && p.NhomThoe == nhomtho);
                        old.deleted = false;
                    }
                    catch (Exception ex)
                    {
                        Tho_Nhom tho_nhom = new Tho_Nhom();
                        tho_nhom.NhomThoe = nhomtho;
                        tho_nhom.NhanVien = nhanvien;
                        tho_nhom.deleted = false;
                    }
                }

                // Get CongViec
                int i = 0;
                while (i < gridView.RowCount)
                {
                    MucDoThanhThao mucdothanhthao = gridView.GetRow(i) as MucDoThanhThao;
                    if (mucdothanhthao == null)
                    {
                        i++;
                        break;
                    }

                    String maCV = null;
                    int mucdo = 0;
                    try
                    {
                        maCV = gridView.GetRowCellValue(i, colMaCV).ToString();
                        mucdo = Int16.Parse(gridView.GetRowCellValue(i, colMucDo).ToString());
                    }
                    catch (Exception) { }

                    if (maCV == null)
                    {
                        MessageBox.Show("Trường công việc không được rỗng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    String MaCVtemp = null;
                    int j = 0;
                    bool f = false;
                    while (j < i)
                    {
                        MaCVtemp = gridView.GetRowCellValue(j, colMaCV).ToString();
                        if (maCV == MaCVtemp)
                        {
                            gridView.DeleteRow(i);
                            f = true;
                            break;
                        }
                        j++;
                    }
                    if (f == true)
                        continue;

                    bool del = (bool)gridView.GetRowCellValue(i, colDelete);
                    if (mucdothanhthao.deleted == true)
                    {
                        if (f_candelete == false)
                        {
                            FormAuthenDelete frmAuthen = new FormAuthenDelete();
                            DialogResult result = frmAuthen.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                mucdothanhthao.deleted = true;
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

                    mucdothanhthao.MaCV = maCV;
                    mucdothanhthao.MucDo = mucdo;
                    mucdothanhthao.NhanVien = nhanvien;
                    mucdothanhthao.deleted = false;

                    i++;
                }

                db.SubmitChanges();
                f_candelete = false;

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Fail", "Fail", MessageBoxButtons.OK);
            //}
        }

        public void load()
        {
            txtFullName.Text = nhanvien.TenNV;
            txtAddress.Text = nhanvien.DiaChi;
            txtLuong.Text = nhanvien.Luong.Value.ToString();
            txtNamSinh.Text = nhanvien.NamSinh.ToString();
            txtPhoneNum.Text = nhanvien.SDT;
            rdoGioiTinh.SelectedIndex = nhanvien.GioiTinh == false ? 0 : 1;

            if (nhanvien.LoaiNV != null)
                lookChucVu.DataBindings.Control.Text = nhanvien.LoaiNV.TenLoaiNV;

            if (nhomtho != null)
                lookNhom.DataBindings.Control.Text = nhomtho.TenNhom;

            try
            {
                var mucdo = from p in db.MucDoThanhThaos
                            where p.deleted == false && p.NhanVien == nhanvien
                            select p;
                mucDoThanhThaoBindingSource.DataSource = mucdo;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        public void Dispose()
        {
            if (f_update)
                reset();
            else
                clear();
        }

        private void clear()
        {
            txtAddress.ResetText();
            txtFullName.ResetText();
            txtLuong.ResetText();
            txtNamSinh.ResetText();
            txtPhoneNum.ResetText();
            lookChucVu.ResetText();
            lookNhom.ResetText();

            mucDoThanhThaoBindingSource.Dispose();
            gridView.RefreshData();
        }

        private void reset()
        {
            //db.GetChangeSet().Updates.Clear();
            //db.GetChangeSet().Inserts.Clear();
            UC_NhanVien_Load(null, null);
        }

        bool checkData()
        {
            bool result = true;

            Check check = new Check();

            result = check.checkEmpty(txtAddress) && result;
            result = check.checkEmpty(txtFullName) && result;
            result = check.checkEmpty(txtLuong) && result;
            result = check.checkEmpty(txtNamSinh) && result;
            result = check.checkEmpty(lookChucVu) && result;
            result = check.checkPhone(txtPhoneNum) && result;

            return result;
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            var nhomthos = from p in db.NhomThoes
                           where p.deleted == false
                           select p;
            nhomThoeBindingSource.DataSource = nhomthos;

            var loainhanvien = from p in db.LoaiNVs
                           where p.deleted == false
                           select p;
            loaiNVBindingSource.DataSource = loainhanvien;

            var congviecs = from p in db.CongViecs
                            where p.deleted == false
                            select p;
            congViecBindingSource.DataSource = congviecs;

            if (f_update == true)
                load();
        }

        private void btnAddCongViec_Click(object sender, EventArgs e)
        {
            gridView.AddNewRow();
        }

    }
}
