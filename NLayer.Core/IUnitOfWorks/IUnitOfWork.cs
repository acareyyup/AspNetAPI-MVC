﻿namespace NLayer.Core.IUnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();


    }
}
