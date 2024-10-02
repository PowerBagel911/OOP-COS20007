using System;
using SwinAdventure;
namespace _2._4___OOP
{
	public abstract class Command : IdentifiableObject 
	{
		public Command(string[] ids) : base(ids)
		{
		}

        // Abstract method Execute, to be implemented in derived classes
        public abstract string Execute(Player p, string[] text);
    }
}

