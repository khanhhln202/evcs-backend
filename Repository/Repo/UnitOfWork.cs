using DAL.DBcontext;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    public interface IUnitOfWork : IDisposable
    {
        UsersRepository UsersRepository { get; }

        BookingsRepository BookingsRepository { get; }

        ChargingSessionsRepository ChargingSessionsRepository { get; }

        InvoicesRepository InvoicesRepository { get; }

        PaymentsRepository PaymentsRepository { get; }

        StationRepository StationRepository { get; }


        VehiclesRepository VehiclesRepository { get; }



        int SaveChangesWithTransaction();

        Task<int> SaveChangesWithTransactionAsync();

    }
    public class UnitOfWork : IUnitOfWork
    {
            private readonly EVCSDBContext _context;
            
            private UsersRepository _accountRepository;
            private BookingsRepository _categoryRepository;
            private ChargingSessionsRepository _mediaAssetRepository;
            private InvoicesRepository _paymentRepository;
            private PaymentsRepository _paymentsRepository;
            private StationRepository _stationRepository;
            private VehiclesRepository _vehiclesRepository;
            public UnitOfWork() => _context = new EVCSDBContext();

            public UsersRepository UsersRepository
            {
                get
                {
                    return _accountRepository ??= new UsersRepository(_context);
                }
            }
            public BookingsRepository BookingsRepository
            {
                get
                {
                    return _categoryRepository ??= new BookingsRepository(_context);
                }
            }
            public ChargingSessionsRepository ChargingSessionsRepository
            {
                get
                {
                    return _mediaAssetRepository ??= new ChargingSessionsRepository(_context);
                }
            }
            public InvoicesRepository InvoicesRepository
            {
                get
                {
                    return _paymentRepository ??= new InvoicesRepository(_context);
                }
            }
            public PaymentsRepository PaymentsRepository
            {
                get
                {
                    return _paymentsRepository ??= new PaymentsRepository(_context);
                }
            }
            public StationRepository StationRepository
            {
                get
                {
                    return _stationRepository ??= new StationRepository(_context);
                }
            }
            public VehiclesRepository VehiclesRepository
            {
                get
                {
                    return _vehiclesRepository ??= new VehiclesRepository(_context);
                }
            }
        
       
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public int SaveChangesWithTransaction()
        {
            int result = -1;

            //System.Data.IsolationLevel.Snapshot
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    result = _context.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch (Exception)
                {
                    //Log Exception Handling message                      
                    result = -1;
                    dbContextTransaction.Rollback();
                }
            }

            return result;
        }

        public async Task<int> SaveChangesWithTransactionAsync()
        {
            int result = -1;

            //System.Data.IsolationLevel.Snapshot
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    result = await _context.SaveChangesAsync();
                    dbContextTransaction.Commit();
                }
                catch (Exception)
                {
                    //Log Exception Handling message                      
                    result = -1;
                    dbContextTransaction.Rollback();
                }
            }

            return result;
        }
    }
     
}
