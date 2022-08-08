using MyLeaveManagement.Domain;

namespace MyLeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
        Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails();
    }
}
