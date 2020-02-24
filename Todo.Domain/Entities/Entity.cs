using System;

namespace Todo.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        // Colocamos o set como private, por que somente aqui a lógica de novo Guid será gerada.
        // Assim evitamos da mesma lógica espalhada pelo código gerando Guids de outras formas.
        public Guid Id { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }
}