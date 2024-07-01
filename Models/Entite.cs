using System;
namespace app.Models;

public abstract class Entite{
    public Guid Id { get; protected set; }
    protected void initId()=> Id = Guid.NewGuid();
}