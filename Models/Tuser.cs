using System;
using System.Collections.Generic;

namespace AFilesAppload.Models;

public partial class Tuser
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string Password { get; set; } = null!;

    public long PhoneNumber { get; set; }

    public byte[] Pdffile { get; set; } = null!;
}
