using System;
using System.Collections.Generic;
using System.Text;
using SParcialAP1.Entidades;
using SParcialAP1.DAL;
using Microsoft.EntityFrameworkCore;

namespace SParcialAP1.BLL
{
    class ProyectoBLL
    {
        public static bool Guardar(Proyecto _proyecto)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                if (db.Proyectos.Add(_proyecto) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Proyecto _proyecto)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(_proyecto).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Proyectos.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Proyecto Buscar(int id)
        {
            Contexto db = new Contexto();
            Proyecto _proyecto = new Proyecto();

            try
            {
                _proyecto = db.Proyectos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return _proyecto;
        }
    }
}
