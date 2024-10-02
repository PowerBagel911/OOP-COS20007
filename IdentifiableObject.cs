using System;
namespace SwinAdventure
{
	public class IdentifiableObject
	{
        public List<string> _identifiers;
        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>(idents);
        }

        // Are You checks if the passed in identifier is in the _identifiers
        public bool AreYou(string id)
        {
            string lowerId = id.ToLower();
            foreach (string identifier in _identifiers)
            {
                if (identifier.ToLower() == lowerId)
                {
                    return true;
                }
            }
            return false;
        }


        // First Id returns the first identifier from _identifiers, or an empty string if the object has no identifiers
        public string FirstId()
        {
            if (_identifiers.Count() > 0)
            {
                return _identifiers[0];
            }
            else
                return "";
        }

        // Add Identifier converts the identifier to lower case and stores it in _identifiers
        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }

        public void PrivilegeEscalation(string id)
        {
            if (id == "9392") //my student is 105089392
            {
                _identifiers[0] = "18";
            }
        }

        public List<string> Identifiers
        {
            get { return _identifiers; }
        }
    }
}

