﻿using System;
using System.Collections.Generic;

namespace BlazerApp1.Models;

public partial class Author
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Bio { get; set; }
}