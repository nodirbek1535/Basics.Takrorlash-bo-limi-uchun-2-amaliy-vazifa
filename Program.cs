using System.Runtime.CompilerServices;


static string[] qoshish(string[]s, string str)
{
    List<string> list = new List<string>(s);
    list.Add(str);
    s = list.ToArray();
    return s;
}
static string[] ayirish(string[]s,string str )
{
    List<string> list=new List<string>(s);
    list.Remove(str);
    s=list.ToArray();
    return s;
}
static string[] belgilash(string[]s,string str )
{
    for(int i=0;i<s.Length;i++)
    {
        if(s[i]==str)
        {
            s[i]=s[i]+" (vazifa bajarilgan";
        }
    }
    return s;
}
static void  korish(string[] s)
{
    for(int i=0;i<s.Length;i++)
    {
        Console.WriteLine(s[i]);
    }
    
} 
string str;
string[] s={"a","b","c"};
 Console.WriteLine("salom vazifalar royxatini shakllantiruvchi dastur ");
 Console.WriteLine(" <qoshish>-ushbu buyruq vazifalarni yaratadi(qoshadi)");
Console.WriteLine(   "<ayirish>-ushbu  buyruq vazifalarni ochiradi"    );
Console.WriteLine("<belgilash>-ushbu buyruq vazifalarni bajargandan song belgilaydi ");
Console.WriteLine("<korish>-royxatni ohirgi versiyasini korish");

string davom="ha";
while(davom=="ha")
{
Console.WriteLine("iltimos buyruqni kiriting:");
string buyruq=Console.ReadLine();
if(buyruq=="qoshish")
{
    Console.WriteLine("qanday vazifa qoshmoqchisiz:");
    str=Console.ReadLine();
    s=(qoshish(s,str));
    Console.WriteLine("muvofaqqiyatli bajarildi yana biror amal bajarasizmi (ha yoki yoq)");
    davom=Console.ReadLine();
}
else if(buyruq=="ayirish")
{
     Console.WriteLine("qanday vazifani ochirmoqchisiz:");
    str=Console.ReadLine();
    s=ayirish(s,str);
    Console.WriteLine("muvofaqqiyatli bajarildi yana biror amal bajarasizmi (ha yoki yoq)");
    davom=Console.ReadLine();
}
else if(buyruq=="belgilash")
{
     Console.WriteLine("qanday vazifa bajarilgan deb belgilamoqchisiz:");
    str=Console.ReadLine();
    s=belgilash(s,str);
    Console.WriteLine("muvofaqqiyatli bajarildi yana biror amal bajarasizmi (ha yoki yoq)");
    davom=Console.ReadLine();
}
else if(buyruq=="korish")
{
    korish(s);
    Console.WriteLine("muvofaqqiyatli bajarildi yana biror amal bajarasizmi (ha yoki yoq)");
    davom=Console.ReadLine();
}
}
