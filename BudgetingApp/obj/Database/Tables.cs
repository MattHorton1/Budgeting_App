public class User
{
    // EF Core recognizes "Id" or "Id" combined with the class name as the Primary Key by convention
    public int UserId { get; set; } 
    private string Username { get; set; } = string.Empty;
    private string Password { get; set; } = string.Empty;
}

public class Earning
{
    public int EarningsId { get; set; }
    public int UserId { get; set; }
    private DateTime EarnedDate { get; set; }
    private float DepositAmount { get; set; }
}

public class Expenditure
{
    public int ExpenditureId { get; set; }
    public int UserId { get; set; }
    private DateTime EarnedDate { get; set; }
    private float WithdrawalAmount { get; set; }
}

public class Projection
{
    public int ProjectionId { get; set; }
    public int UserId { get; set; }
    public float ProjectedWeeklyEarning { get; set; }

}

public class Goal
{
    public int GoalId { get; set; }
    public int UserId { get; set; }
    public string GoalTitle { get; set; }
    public string GoalDescription { get; set; }
    public DateTime GoalDeadline { get; set; }
}