using Microsoft.AspNetCore.Components;
using EmployeeManagement.Shared;
using EmployeeManagement.Client.Services;
using MudBlazor;
using EmployeeManagement.Client.Shared;

namespace EmployeeManagement.Client.Pages.Identity.Profile;

public partial class Profile
{
    public Employee Employee { get; set; } = new Employee();
    private bool OnDaily = true;
    private bool OnWeekly = false;

    [Inject]
    public IEmployeeService EmployeeService { get; set; }

    [Parameter]
    public string Id { get; set; }

    protected async override Task OnInitializedAsync()
    {
        Id = Id ?? "1";
        Employee = await EmployeeService.GetEmployee(int.Parse(Id));
    }

    // SETTINGS POPOVER
    public bool _isOpen;

    public void ToggleOpen()
    {
        if (_isOpen)
            _isOpen = false;
        else
            _isOpen = true;
    }

    public void ToggleCalendar()
    {
        OnDaily = !OnDaily;
        OnWeekly = !OnWeekly;
    }

    // PIECHART DEMO
    private int Index = -1; //default value cannot be 0 -> first selectedindex is 0.
    int dataSize = 4;
    double[] piechartData = { 77, 25, 20, 5 };
    string[] piechartLabels = { "Teamwork", "Communication", "Problem solving", "Planning and organising" };

    // Donut DEMO

    public double[] donutData = { 25, 77, 28, 5 };
    public string[] donutLabels = { "Overtime", "Attending", "Absent", "Leave" };

    // LINE CHART DEMO
    public List<ChartSeries> Series = new List<ChartSeries>();
    public ChartOptions Options = new ChartOptions();
    public string[] XAxisLabels = { "2021-04-20", "2021-04-21", "2021-04-22", "2021-04-23", "2021-04-24", "2021-04-25", "2021-04-26" };
    protected override void OnInitialized()
    {
        double[] Data1 = { 65, 68, 70, 74, 74, 72, 74 };
        double[] Data2 = { 88, 90, 91, 92, 91, 90, 90 };
        double[] Data3 = { 89, 91, 92, 92, 92, 92, 91 };
        double[] Data4 = { 85, 86, 90, 90, 92, 99, 0 };


        Series.Add(new ChartSeries() { Name = "Email", Data = Data1 });
        Series.Add(new ChartSeries() { Name = "Customer", Data = Data2 });
        Series.Add(new ChartSeries() { Name = "Development", Data = Data3 });
        Series.Add(new ChartSeries() { Name = "Project", Data = Data4 });

        Options.YAxisTicks = 400;

        StateHasChanged();
    }
}