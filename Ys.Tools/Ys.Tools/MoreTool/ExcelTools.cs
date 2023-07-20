using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MiniExcelLibs;

namespace Ys.Tools.MoreTool;

public class ExcelTools
{
    /// <summary>
    /// 读取CSV文件
    /// </summary>
    /// <param name="path"></param>
    public static List<dynamic> ReadCsv(string path)
    {
        // Read
        var config = new MiniExcelLibs.Csv.CsvConfiguration()
        {
            StreamReaderFunc = (stream) => new StreamReader(stream, Encoding.GetEncoding("gb2312"))
        };
        var rows = MiniExcel.Query(path,
            excelType: ExcelType.CSV, configuration: config).ToList();
        return rows;
    }

    /// <summary>
    /// 读取文件-默认
    /// </summary>
    /// <param name="path"></param>
    public static List<dynamic> Read(string path)
    {
        var rows = MiniExcel.Query(path).ToList();
        return rows;
    }

}