using System;
using System.Collections.Generic;

namespace AFilesAppload.Models;

public partial class ApploadFile
{
    public int Id { get; set; }

    public string? FileName { get; set; }

    public byte[]? Filedata { get; set; }

    public int? Filetype { get; set; }
}
