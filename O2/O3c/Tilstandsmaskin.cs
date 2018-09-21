using System.Collections.Generic;

namespace O3c
{
    public interface Tilstandsmaskin
    {
        List<Aksjon> HaandtereHendeøse(Hendelse h);
    }
}