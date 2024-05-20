using System;

namespace MyWebForms.Core.Web
{
    public readonly struct SessionKey
    {
        public string Name { get; }

        public Type Type { get; }

        public SessionKey(string name, Type type)
        {
            Name = name;
            Type = type;
        }

        public override string ToString() => Name;

    }
}
