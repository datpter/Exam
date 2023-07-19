using Exam.Data;
using Exam.Models;

namespace Exam;

public class MembershipController
{
    // context: 1 phien ket noi giua C# va SQL Server
    private readonly DataContext _context;

    public MembershipController(DataContext context)
    {
        _context = context;
    }

    public void Add(Membership membership)
    {
        try
        {
            _context.Add(membership);
            _context.SaveChanges();
            Console.WriteLine("Add membership successfully");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Add membership failed: " + ex.Message);
        }
    }

    public List<Membership> GetAll()
    {
        try
        {
            var memberships = _context.Memberships.ToList();
            return memberships;
        }
           
        catch(Exception ex)
        {
            Console.WriteLine("Get memberships failed: " + ex.Message);
            return null;
        }
      
    }

    // GetById()

    // Update()

    // Delete()
}
