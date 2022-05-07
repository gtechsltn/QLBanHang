using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Lấy thông tin Tên đăng nhập (UserId) người dùng nhập vào
            var userId = txtUserId.Text;

            //Lấy thông tin Mật khẩu (Password) người dùng nhập vào
            var password = txtPassword.Text;

            //Mã hóa mật khẩu bằng một hàm có sẵn
            var passwordEncrypted = EncrytPassword(password);

            //Lấy chuỗi kết nối
            var connString = ConfigurationManager.ConnectionStrings["QLBH"].ConnectionString;

            #region DAL: Data Access Layer (Sample)

            // public sealed class SqlConnection
            // public abstract class DbConnection : IDisposable
            // SqlConnection <- DbConnection : IDisposable
            using (var conn = new SqlConnection(connString))
            {
                //Mở connection
                conn.Open();

                //Thực thi câu lệnh
                //Do something
            }

            #endregion DAL: Data Access Layer (Sample)

            #region DAL: Data Access Layer

            //Tạo connection đến cơ sở dữ liệu
            using (var conn = new SqlConnection(connString))
            {
                //Mở connection
                conn.Open();

                //Tạo command
                using (var cmd = conn.CreateCommand())
                {
                    //Gán nội dung câu lệnh select
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DangNhap";

                    //Xóa các parameters
                    cmd.Parameters.Clear();

                    //Thêm các parameters cần thiết cho Stored Procedure
                    cmd.Parameters.AddWithValue("email", userId);
                    cmd.Parameters.AddWithValue("matkhau", passwordEncrypted);

                    //Thực thi câu lệnh select
                    var returnValue = cmd.ExecuteScalar();

                    //cmd để thực hiện CRUD CSharp             : (C: Create, R: Read  , U: Update, D: Delete)
                    //cmd để thực hiện CRUD T-SQL in SQL Server: (C: INSERT, R: SELECT, U: UPDATE, D: DELETE)

                    //Tìm hiểu thêm về các lệnh bên dưới:
                    //cmd.ExecuteNonQuery(); //Insert, Update, Delete => Number of Rows Affected
                    //cmd.ExecuteScalar(); //Stored Procedure => First Column of First Row
                    //cmd.ExecuteReader(); //Read to SqlDataReader

                    #region BUS: Business Logic Layer

                    if (Convert.ToInt32(returnValue) == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                    }

                    #endregion BUS: Business Logic Layer
                }
            }

            #endregion DAL: Data Access Layer
        }

        /// <summary>
        /// Mã hóa mật khẩu
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string EncrytPassword(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (var item in encrypt)
            {
                builder.Append(item.ToString());
            }
            return builder.ToString();
        }
    }
}