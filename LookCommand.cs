using _2._4___OOP;

public class LookCommand : Command
{
    public LookCommand() : base(new string[] { "look" })
    {
    }

    public override string Execute(Player p, string[] text)
    {

        if (text[0].ToLower() != "look")
        {
            return "Error in look input";
        }

        if (text[1].ToLower() != "at")
        {
            return "What do you want to look at?";
        }

        IHaveInventory? container;

        switch (text.Length)
        {
            case 3:
                container = p;
                break;
            case 5:
                if (text[3].ToLower() != "in")
                {
                    return "What do you want to look in?";
                } else
                {
                    container = FetchContainer(p, text[4]);
                    if (container == null)
                    {
                        return $"I cannot find the {text[4]}";
                    }
                    break;
                }
            default:
                return "I don't know how to look like that";
        }
        return LookAtIn(text[2], container);

        

    }

    private IHaveInventory? FetchContainer(Player p, string containerId)
    {
        GameObject? obj = p.Locate(containerId);
        return obj as IHaveInventory;
    }

    private string LookAtIn(string thingId, IHaveInventory container)
    {
        GameObject obj = container.Locate(thingId);
        if (obj == null)
        {
            return $"I cannot find the {thingId} in the {container.Name}";
        }
        return obj.FullDescription;
    }
}
