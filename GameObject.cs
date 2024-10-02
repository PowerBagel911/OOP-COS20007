using System;
using SwinAdventure;

namespace _2._4___OOP
{
	public abstract class GameObject : IdentifiableObject
    {
        public string _name;
        public string _description;
		
		public GameObject(string[] ids, string name, string description) : base(ids)
		{
			_name = name;
			_description = description;
		}

		public string Name
		{
			get { return _name; }
		}

		public string ShortDescription
		{
			get { return $"{_name} ({FirstId()})"; }
		}

		public virtual string FullDescription
		{
			get { return _description; }
		}

        public virtual GameObject? Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return null;
        }
    }
}

