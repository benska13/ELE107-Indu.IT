using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O2
{
    public interface ITilstandsmaskin
    {
        List<Aksjon> HaandtereHendelse(Hendelse h);
    }
}
