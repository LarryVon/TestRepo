using System;
namespace SFEpic.Data
{
    public interface IRowProperty
    {
        bool CanGet { get; set; }
        bool CanSet { get; set; }
        IDataColumn Column { get; }
        bool IsChanged { get; }
        bool IsSet { get; set; }
        event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        DataRow Row { get; }
        object Value { get; set; }
    }
}
