﻿using DotNetSurfer.DAL.Entities;
using DotNetSurfer.DAL.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace DotNetSurfer.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DotNetSurferDbContext _dbContext;
        private readonly Lazy<ITopicRepository> _topicRepository;
        private readonly Lazy<IArticleRepository> _articleRepository;
        private readonly Lazy<IAnnouncementRepository> _announcementRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IFeatureRepository> _featureRepository;
        private readonly Lazy<IStatusRepository> _statusRepository;

        public UnitOfWork(DotNetSurferDbContext dbContext)
        {
            this._dbContext = dbContext;
            this._topicRepository = new Lazy<ITopicRepository>(() => new TopicRepository(this._dbContext));
            this._articleRepository = new Lazy<IArticleRepository>(() => new ArticleRepository(this._dbContext));
            this._announcementRepository = new Lazy<IAnnouncementRepository>(() => new AnnouncementRepository(this._dbContext));
            this._userRepository = new Lazy<IUserRepository>(() => new UserRepository(this._dbContext));
            this._featureRepository = new Lazy<IFeatureRepository>(() => new FeatureRepository(this._dbContext));
            this._statusRepository = new Lazy<IStatusRepository>(() => new StatusRepository(this._dbContext));
        }

        public ITopicRepository TopicRepository
        {
            get { return this._topicRepository.Value; }
        }

        public IArticleRepository ArticleRepository
        {
            get { return this._articleRepository.Value; }
        }

        public IAnnouncementRepository AnnouncementRepository
        {
            get { return this._announcementRepository.Value; }
        }

        public IUserRepository UserRepository
        {
            get { return this._userRepository.Value; }
        }

        public IFeatureRepository FeatureRepository
        {
            get { return this._featureRepository.Value; }
        }

        public IStatusRepository StatusRepository
        {
            get { return this._statusRepository.Value; }
        }

        public async Task<int> SaveAllChangesAsync()
        {
            return await this._dbContext.SaveChangesAsync();
        }
    }
}
