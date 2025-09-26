using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{   public interface IServiceProvides
    {
        UsersService UsersService { get; }
        VehiclesServices VehiclesServices { get; }
        ChargingSessionsServices ChargingSessionsServices { get; }
        BookingsServices BookingsServices { get; }
        InvoicesServices InvoicesServices { get; }
        PaymentsServices PaymentsServices { get; }
        StationsServices StationsServices { get; }


    }
    public class ServiceProvides : IServiceProvides
    {
        private UsersService _usersService;
        private VehiclesServices _vehiclesServices;
        private ChargingSessionsServices _chargingSessionsServices;
        private BookingsServices _bookingsServices;
        private InvoicesServices _invoicesServices;
        private PaymentsServices _paymentsServices;
        private StationsServices _stationsServices;

        IServiceProvider _IServiceProvider { get; }

        IUsersServices _UsersServices { get; }
        IVehiclesServices _VehiclesServices { get; }
        IChargingSessionsServices _ChargingSessionsServices { get; }
        IBookingsServices _BookingsServices { get; }
        IInvoicesServices _InvoicesServices { get; }
        IPaymentsServices _PaymentsServices { get; }
        IStationsServices _StationsServices { get; }



        public ServiceProvides() { }

        public UsersService UsersService
        {
            get
            {
                return _usersService ??= new UsersService();
            }
        }

        public VehiclesServices VehiclesServices
        {
            get
            {
                return _vehiclesServices ??= new VehiclesServices();
            }
        }

        public ChargingSessionsServices ChargingSessionsServices
        {
            get
            {
                return _chargingSessionsServices ??= new ChargingSessionsServices();
            }
        }

        public BookingsServices BookingsServices
        {
            get
            {
                return _bookingsServices ??= new BookingsServices();
            }
        }   


        public InvoicesServices InvoicesServices
        {
            get
            {
                return _invoicesServices ??= new InvoicesServices();
            }
        }   

        public PaymentsServices PaymentsServices
        {
            get
            {
                return _paymentsServices ??= new PaymentsServices();
            }
        }   

        public StationsServices StationsServices
        {
            get
            {
                return _stationsServices ??= new StationsServices();
            }
        }

        public IUsersServices IUsersServices
        {
            get
            {
                return _usersService ??= new UsersService();
            }
        }

        public IChargingSessionsServices IChargingSessionsServices
        {
            get
            {
                return _chargingSessionsServices ??= new ChargingSessionsServices();
            }
        }

        public IInvoicesServices IInvoicesServices
        {
            get
            {
                return _invoicesServices ??= new InvoicesServices();
            }
        }

        public IPaymentsServices IPaymentsServices
        {
            get
            {
                return _paymentsServices ??= new PaymentsServices();
            }
        }

        public IStationsServices IStationsServices
        {
            get
            {
                return _stationsServices ??= new StationsServices();
            }
        }

        public IVehiclesServices IVehiclesServices
        {
            get
            {
                return _vehiclesServices ??= new VehiclesServices();
            }
        }   
    }
}
