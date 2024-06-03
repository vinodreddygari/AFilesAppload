using System;
using System.Collections.Generic;

namespace AFilesAppload.Models;

public partial class User
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPassword { get; set; }

    public byte[]? PdfFile { get; set; }
}
