using Microsoft.EntityFrameworkCore;
using Registro_de_Clientes.DAL;
using Registro_de_Clientes.Model;
using System.Collections.Generic;
using System.Linq.Expressions;



namespace Registro_de_Clientes.BLL
{
    public class ClienteBLL
    {
        private Contexto _contexto;


        public ClienteBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int clientesId)
        {
            return _contexto.Clientes.Any(o => o.ClientesId == clientesId);
        }

        public bool Insertar(Clientes clientes)
        {
            _contexto.Clientes.Add(clientes);
            return _contexto.SaveChanges() > 0;
        }

        public bool Modificar(Clientes clientes)
        {
            _contexto.Entry(clientes).State = EntityState.Modified;
            return _contexto?.SaveChanges() > 0;
        }

        public bool Guardar(Clientes clientes)
        {
            if(!Existe(clientes.ClientesId))
            {
                return this.Insertar(clientes);
            }
            else
            {
                return this.Modificar(clientes);
            }
        }

        public bool Eliminar(Clientes clientes)
        {
            _contexto.Entry(clientes).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }

        public Clientes? Buscar(int clienteid)
        {
            return _contexto.Clientes.Where(o => o.ClientesId == clienteid)
                .AsNoTracking().SingleOrDefault();
        }

        public List<Clientes> GetList(Expression<Func<Clientes, bool>> expression)
        {
            return _contexto.Clientes.AsNoTracking().Where(expression).ToList();
        }

        public List<Clientes> BuscarPorId(int id)
        {
            return _contexto.Clientes.AsNoTracking().Where(c => c.ClientesId == id).ToList();
        }
    }
}
