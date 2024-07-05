using System;
using System.Collections.Generic;

namespace AdminPaneli.Models;

public partial class Admin
{
    public int AdminId { get; set; }

    public string? Ad { get; set; }

    public string? Sifre { get; set; }

    public string? Mail { get; set; }

    public string? MailSifre { get; set; }
}
