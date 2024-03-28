using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using movie_reservation_system.DAL;
using movie_reservation_system.Entities;

namespace movie_reservation_system.BLL
{
    internal class MovieBusinessLogicObject
    {
        private readonly MovieDataAccessObject _movieDataAccessObject = new MovieDataAccessObject();

        private static T MapToEntity<T>(DataRow row, IEnumerable<PropertyInfo> properties) where T : new()
        {
            var entity = new T();
            foreach (var property in properties)
                property.SetValue(entity, Convert.ChangeType(row[property.Name], property.PropertyType));
            return entity;
        }

        private static IList<T> MapToEntityList<T>(DataTable dt) where T : new()
        {
            return (from DataRow row in dt.Rows select MapToEntity<T>(row, typeof(T).GetProperties())).ToList();
        }

        public IList<Movie> GetMovieComingSoon()
        {
            return MapToEntityList<Movie>(_movieDataAccessObject.GetMovieComingSoon());
        }

        public IList<Movie> GetMovieNowShowing()
        {
            return MapToEntityList<Movie>(_movieDataAccessObject.GetMovieNowShowing());
        }
    }
}