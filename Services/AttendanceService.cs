using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventEase.Services;

public class AttendanceService
{
    private List<Attendance> attendances = new List<Attendance>();

    public Task SaveAttendanceAsync(Attendance attendance)
    {
        attendances.Add(attendance);
        return Task.CompletedTask;
    }

    public Task<List<Attendance>> GetAttendancesAsync()
    {
        return Task.FromResult(attendances);
    }
}