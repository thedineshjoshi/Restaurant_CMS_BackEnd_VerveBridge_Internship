using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Header.Queries.GetHeader
{
    public class GetHeaderQuery : IRequest<HeaderDto>
    {
    }
}
