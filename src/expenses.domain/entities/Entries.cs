using System;

namespace expenses.domain.entities;

public class Entries
{
    public Place Place { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public Category Category { get; set; }
    public DateTime EntryDate { get; set; }
    public string Title { get; set; }
    public bool IsExpense { get; set; }
    public decimal EntryValue { get; set; }
}