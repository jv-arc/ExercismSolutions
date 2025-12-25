

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
                break;
                
            case 2:
                return "left back";
                break;

            case 3 or 4:
                return "center back";
                break;

            case 5:
                return "right back";
                break;

            case 6 or 7 or 8:
                return "midfielder";
                break;

            case 9:
                return "left wing";
                break;

            case 10:
                return "striker";
                break;

            case 11:
                return "right wing";
                break;

            default:
                return "UNKNOWN";
                break;
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case Incident incident when incident is Injury:
                return $"Oh no! {incident.GetDescription()} Medics are on the field.";
                break;
                
            case Incident incident:
                return incident.GetDescription();
                break;

            case Manager manager:
                if(manager.Club==null)
                {
                    return manager.Name;
                }
                else
                {
                    return $"{manager.Name} ({manager.Club})";   
                }
                break;
                
            case int numberOfSupporters:
                return $"There are {numberOfSupporters} supporters at the match.";
                break;

            case string announcement:
                return announcement;
                break;

            default:
                return "";
                break;
                
        }
    }
}
