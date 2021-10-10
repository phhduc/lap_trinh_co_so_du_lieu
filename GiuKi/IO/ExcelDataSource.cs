using GiuKi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace GiuKi.IO
{
    public class ExcelDataSource:IDataSource
    {
        public string _filepath;
        public ExcelDataSource(string fn)
        {
            this._filepath = fn;
        }

        public List<Sv> GetSv()
        {
            throw new NotImplementedException();
        }

        public void Save(List<Sv> Students)
        {
            _Application ex = new Excel.Application();
            Workbook wk = ex.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = wk.Worksheets[1];
            int row = 1;
            ws.Cells[1, 1] = "MSSV";
            ws.Cells[1, 2] = "Họ và tên lót";
            ws.Cells[1,3]= "Tên";
            ws.Cells[1,4] = "Giới tính";
            ws.Cells[1,5] = "Ngày sinh";
            ws.Cells[1,6] = "Số điện thoại";
            ws.Cells[1,7] = "Địa chỉ";
            ws.Cells[1,8] = "Lớp";
            ws.Cells[1,9] = "Khoa";
            foreach(var x in Students)
            {
                row++;
                ws.Cells[row, 1] = x.StudentId;
                ws.Cells[row, 2] = x.FirstName;
                ws.Cells[row, 3] = x.LastName;
                if (x.Gender) ws.Cells[row, 4] = "Nam";
                else ws.Cells[row, 4] = "Nữ";
                ws.Cells[row, 5] = x.DateOfBirth.ToString();
                ws.Cells[row, 6] = x.PhoneNumber;
                ws.Cells[row, 7] = x.Address;
                ws.Cells[row, 8] = x.ClassName;
                ws.Cells[row, 9] = x.FacultyName;
            }
            wk.SaveAs(_filepath);
            wk.Close();
        }
    }
}
