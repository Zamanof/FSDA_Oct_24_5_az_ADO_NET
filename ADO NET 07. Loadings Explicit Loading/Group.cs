namespace ADO_NET_07._Loadings_Explicit_Loading;

class Group
{
    public int Id { get; set; }
    public string GroupName { get; set; }
    public List<Student> Students { get; set; }
    public override string ToString()
    {
        return GroupName;
    }
}
