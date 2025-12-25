static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string badgeDepartment;
        
        if(department==null)
        {
            badgeDepartment = "OWNER";    
        }
        else
        {
            badgeDepartment = department.ToUpper();
        }
        
        if(id == null)
        {
            return $"{name} - {badgeDepartment}";
        }
        else
        {
            return $"[{id}] - {name} - {badgeDepartment}";
        }
        
    }
}
