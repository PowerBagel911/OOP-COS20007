using System;
namespace _2._4___OOP
{
	public interface IHaveInventory
	{
        GameObject Locate(string id);
        string Name { get; }
    }
}

