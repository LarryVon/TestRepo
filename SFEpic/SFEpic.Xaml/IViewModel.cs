using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFEpic.Xaml
{
    public interface IViewModel
    {
        bool IsSelected { get; set; }
        object Model { get; set; }
    }
}
