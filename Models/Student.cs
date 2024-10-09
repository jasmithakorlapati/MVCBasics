using System;
using System.Collections.Generic;

namespace MVCBasics.Models;

public partial class Student
{
    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public int RollNo { get; set; }

    public string Adress { get; set; } = null!;

    public string Class { get; set; } = null!;

    public string Percentage { get; set; } = null!;
}
