using System;
using System.Collections;
using Atlas.Common.SharedKernel;
using Microsoft.AspNetCore.Session;

namespace OverwatchProject
{
    public class Hero : AssignedEntity, IAggregateRoot
    {
        internal Hero(int id, string name, int health, int damage)
        {
            HeroId = id;
            Name = name;
            Health = health;
            Damage = damage;
        }

        protected Hero()
        {

        }

        public virtual int HeroId { get; set; }

        public virtual string Name { get; set; }

        public virtual int Health { get; set; }

        public virtual int Damage { get; set; }

        public virtual int Version { get; protected set; }
    }
}