using Dominio.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        //Metodo Crear
        public void Add(TEntity entity)
        {
            try
            {
                using (var context = new StayHubEntities())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar registro:" + ex.Message, ex);
            }
        }

        //Metodo Modificar
        public void Modify(TEntity entity)
        {
            try
            {
                using (var context = new StayHubEntities())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar registro:" + ex.Message, ex);
            }
        }

        //Metodo Eliminar
        public void Delete(int id)
        {
            try
            {
                using (var context = new StayHubEntities())
                {
                    var entity = context.Set<TEntity>().Find(id);
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }
            }catch (Exception ex)
            {
                throw new Exception("Error al eliminar registro:" + ex.Message, ex);
            }
        }

        //Metodo Get by Id
        public TEntity Get(int id)
        {
            try
            {
                using (var context = new StayHubEntities())
                {
                    return context.Set<TEntity>().Find(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer registro:" + ex.Message, ex);
            }
        }

        //Metodo Get
        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                using (var context = new StayHubEntities())
                {
                    return context.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer registros:" + ex.Message, ex);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
