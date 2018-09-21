using System.Collections.Generic;

namespace VeibomLibary
{
    public interface ITilstandsmaskin
    {
        List<Aksjon> HaandterHendelse(Hendelse h);
    }
}