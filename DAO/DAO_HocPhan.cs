using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using DTO;
namespace DAO
{
    public class DAO_HocPhan
    {
        public static DataTable DanhSachHocPhanTongQuan(int MaHV)
        {

            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachHocPhanTongQuan(MaHV), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dt.Columns.Add("SOMONDAHOC");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string TenHocPhan = dt.Rows[i]["TENHOCPHAN"].ToString();
                    DataTable dtHocPhanChiTiet = DanhSachHocPhanChiTiet(MaHV, TenHocPhan);
                    int SoMonDaHoc = 0;
                    for (int j = 0; j < dtHocPhanChiTiet.Rows.Count; j++)
                    {
                        if (dtHocPhanChiTiet.Rows[j]["DIEM"].ToString() != "")
                            SoMonDaHoc++;
                    }
                    dt.Rows[i]["SOMONDAHOC"] = SoMonDaHoc.ToString();
                }
                dt.Columns.Add("DTBHOCPHAN");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string TenHocPhan = dt.Rows[i]["TENHOCPHAN"].ToString();
                    DataTable dtHocPhanChiTiet = DanhSachHocPhanChiTiet(MaHV, TenHocPhan);
                    int SoMonDaHoc = 0;
                    float TongDiem = 0;
                    float DTBHocPhan = 0;
                    for (int j = 0; j < dtHocPhanChiTiet.Rows.Count; j++)
                    {
                        if (dtHocPhanChiTiet.Rows[j]["DIEM"].ToString() != "")
                        {
                            SoMonDaHoc++;
                            TongDiem += float.Parse(dtHocPhanChiTiet.Rows[j]["DIEM"].ToString());
                        }
                    }
                    if (SoMonDaHoc != 0 && SoMonDaHoc == Int32.Parse(dt.Rows[i]["SOMONPHAIHOC"].ToString()))
                    {
                        dt.Rows[i]["DTBHOCPHAN"] = (TongDiem / SoMonDaHoc).ToString();
                    }
                    else
                    {
                        dt.Rows[i]["DTBHOCPHAN"] = "";
                    }
                    dt.Rows[i]["SOMONDAHOC"] = SoMonDaHoc.ToString();
                }
                conn.Close();
                return dt;
            }
        }

        public static DataTable LayDanhSachTenHP()
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.LayDanhSachTenHP(), conn);
                DataTable dt = new DataTable();
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable DanhSachHocPhanChiTiet(int MaHV, string TenHocPhan)
        {
            DataTable DiemHV = new DataTable();
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.LayDiemMH(MaHV, TenHocPhan), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                oda.Fill(DiemHV);
                conn.Close();
            }
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachHocPhanChiTiet(MaHV, TenHocPhan), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dt.Columns.Add("DIEM");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int DiemHP;
                    try
                    {
                        DiemHP = Int32.Parse(dt.Rows[i]["MAMH"].ToString());
                    }
                    catch
                    {
                        return dt;
                    }
                    for (int j = 0; j < DiemHV.Rows.Count; j++)
                    {
                        int dtDiem = Int32.Parse(DiemHV.Rows[j]["MAMH"].ToString());
                        if (DiemHP == dtDiem)
                        {
                            string Diem = DiemHV.Rows[j]["DIEM"].ToString();
                            dt.Rows[i]["DIEM"] = Diem;
                        }
                    }
                }
                conn.Close();
                return dt;
            }

        }




        public static DataTable LayTrangThaiDKHocPhan()
        {
            using(OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.TrangThaiDangKy("Hoc Phan"), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable DanhSachHocPhan(int MaHV, int HocKy, int NamHoc)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachHocPhan(MaHV, HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable KetQuaDangKyHP(int MaHV, int HocKy, int NamHoc)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.KetQuaDangKyHP(MaHV, HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static bool DangKyHocPhan(int MaHV, int MaLop)
        {
            try
            {
                int MaDKHocPhan = 0;
                using(OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.LayMaDKHPLonNhat(), conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    conn.Close();
                    MaDKHocPhan = Int32.Parse(dt.Rows[0]["MADKHOCPHAN"].ToString());
                }
                MaDKHocPhan++;
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.DangKyHocPhan(MaHV, MaLop, MaDKHocPhan), conn);
                    cmd.ExecuteReader();
                    conn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public static bool HuyDangKyHocPhan(int MaHV, int MaLop)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.HuyDangKyHocPhan(MaHV, MaLop), conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }



        public static DataTable LayDanhSachNamHoc()
        {
            using(OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.LayDanhSachNamHoc(), conn);
                DataTable dt = new DataTable();
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static DataTable DanhSachLopMo(int HocKy, int NamHoc)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachLopMo(HocKy, NamHoc), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }


        //Thi Lai
        public static string LayMaDKHocPhanTuongUng(int MaHV, int MaMH)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.LayMaDKHocPhanTuongUng(MaHV, MaMH), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt.Rows[0]["MADKHOCPHAN"].ToString();
            }
        }

        public static DataTable DanhSachHocPhanThiLai(int MaHV)
        {
            try
            {
                DataTable dsHocPhanTongQuan = DanhSachHocPhanTongQuan(MaHV);
                DataTable dsHocPhanThiLaiTongQuat = new DataTable();
                dsHocPhanThiLaiTongQuat.Columns.Add("MAHOCPHAN");
                dsHocPhanThiLaiTongQuat.Columns.Add("TENHOCPHAN");
                dsHocPhanThiLaiTongQuat.Columns.Add("MAMH");
                dsHocPhanThiLaiTongQuat.Columns.Add("TENMH");
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachHocPhanThiLai(MaHV), conn);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    oda.Fill(dsHocPhanThiLaiTongQuat);
                    conn.Close();
                }
                DataTable dsHocPhanPhu = new DataTable();
                dsHocPhanPhu.Columns.Add("MAHOCPHAN");
                dsHocPhanPhu.Columns.Add("TENHOCPHAN");
                dsHocPhanPhu.Columns.Add("MAMH");
                dsHocPhanPhu.Columns.Add("TENMH");
                DataTable dsHocPhanDuocPhepDangKy = new DataTable();
                DataRow row;
                dsHocPhanDuocPhepDangKy.Columns.Add("MAHOCPHAN");
                dsHocPhanDuocPhepDangKy.Columns.Add("TENHOCPHAN");
                dsHocPhanDuocPhepDangKy.Columns.Add("MAMH");
                dsHocPhanDuocPhepDangKy.Columns.Add("TENMH");

                for (int i = 0; i < dsHocPhanTongQuan.Rows.Count; i++)
                {
                    if (dsHocPhanTongQuan.Rows[i]["DTBHOCPHAN"].ToString() != "" && Int32.Parse(dsHocPhanTongQuan.Rows[i]["DTBHOCPHAN"].ToString()) < 5)
                    {
                        DataTable dsHocPhanChiTiet = DanhSachHocPhanChiTiet(MaHV, dsHocPhanTongQuan.Rows[i]["TENHOCPHAN"].ToString());
                        for (int j = 0; j < dsHocPhanChiTiet.Rows.Count; j++)
                        {
                            row = dsHocPhanPhu.NewRow();
                            row["MAHOCPHAN"] = dsHocPhanChiTiet.Rows[j]["MAHOCPHAN"].ToString();
                            row["TENHOCPHAN"] = dsHocPhanChiTiet.Rows[j]["TENHOCPHAN"].ToString();
                            row["MAMH"] = dsHocPhanChiTiet.Rows[j]["MAMH"].ToString();
                            row["TENMH"] = dsHocPhanChiTiet.Rows[j]["TENMH"].ToString();
                            dsHocPhanPhu.Rows.Add(row);
                        }
                    }
                }
                for (int i = 0; i < dsHocPhanPhu.Rows.Count; i++)
                {
                    for (int j = 0; j < dsHocPhanThiLaiTongQuat.Rows.Count; j++)
                    {
                        if (dsHocPhanPhu.Rows[i]["MAMH"].ToString() == dsHocPhanThiLaiTongQuat.Rows[j]["MAMH"].ToString())
                        {
                            row = dsHocPhanDuocPhepDangKy.NewRow();
                            row["MAHOCPHAN"] = dsHocPhanPhu.Rows[i]["MAHOCPHAN"].ToString();
                            row["TENHOCPHAN"] = dsHocPhanPhu.Rows[i]["TENHOCPHAN"].ToString();
                            row["MAMH"] = dsHocPhanPhu.Rows[i]["MAMH"].ToString();
                            row["TENMH"] = dsHocPhanPhu.Rows[i]["TENMH"].ToString();
                            dsHocPhanDuocPhepDangKy.Rows.Add(row);
                        }
                    }
                }
                return dsHocPhanDuocPhepDangKy;
            }
            catch
            {
                return new DataTable();
            }
        }

        public static DataTable KetQuaDangKyThiLai(int MaHV)
        {
            using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(DAO_Query.DanhSachHocPhanThiLaiDaDK(MaHV), conn);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                conn.Close();
                return dt;
            }
        }

        public static bool DangKyThiLai(int MaHV, int MaMH)
        {
            try
            {
                int MaDKHocPhan = 0;
                int STT = 0;
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.LayMaDKHocPhanTuongUng(MaHV, MaMH), conn);
                    MaDKHocPhan = Int32.Parse(cmd.ExecuteScalar().ToString());
                    conn.Close();
                }
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.LaySTTLonNhat(MaDKHocPhan), conn);
                    if (cmd.ExecuteScalar().ToString() == "")
                    {
                        STT++;
                    }
                    else
                        STT = Int32.Parse(cmd.ExecuteScalar().ToString()) + 1;
                    conn.Close();
                }
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.DangKyThiLai(MaDKHocPhan, STT), conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public static bool HuyDangKyThiLai(int MaHV, int MaDKHocPhan, int STT)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(DAO_DataProvider.adminConnectionString))
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(DAO_Query.HuyDangKyThiLai(MaHV, MaDKHocPhan, STT), conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


    }
}


