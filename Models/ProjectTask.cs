using System;
using System.ComponentModel.DataAnnotations;

namespace ConstructionScheduler.Models
{
    public class ProjectTask
{
    public int Id { get; set; }
    
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Status { get; set; } = string.Empty;
}

}