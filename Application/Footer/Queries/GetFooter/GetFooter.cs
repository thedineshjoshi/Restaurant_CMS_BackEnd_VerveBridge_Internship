using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Footer.Queries.GetFooter
{
    public class GetFooterQuery : IRequest<FooterDto>
    {
    }
}
