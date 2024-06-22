using Rent_A_Car.CQRS.Commands;
using Rent_A_Car.DAL;

namespace Rent_A_Car.CQRS.Handlers
{
    public class RemoveCarCommandHandler
    {
        private readonly Context _context;

        public RemoveCarCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveCarCommand command)
        {
            var value = _context.Cars.Find(command.CarId);
            _context.Cars.Remove(value);
            _context.SaveChanges();
        }
    }
}
