



abstract class OS
{
    public string name;
    public string version;
    public int year;

    public OS(string name, string version, int year)
    {
        this.name = name;
        this.version = version;
        this.year = year;
    }
}

class VMVareMachine : OS
{
    public string nameVM;

    public VMVareMachine(string name, string version, int year, string nameVm) : base(name, version, year)
    {
        this.name = name;
        this.version = version;
        this.year = year;
        this.nameVM = nameVm;
    }

    public virtual List<OS> list(List<OS> function, string purpose)
    {
        List<OS> op = new List<OS>();
        forech(var i in list )
        {
        }
    }
}

class Monitoring : OS
{
    public string NameM;

    public Monitoring(string name, string version, int year, string nameM) : base(name, version, year)
    {
        this.name = name;
        this.version = version;
        this.year = year;
        this.NameM = nameM;
    }
}