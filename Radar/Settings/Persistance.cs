﻿using System.IO;

namespace Radar.Settings
{
    public static class Persistance
    {
        #region Constants

        private const string SAVE_DIRECTORY = @".\Settings\Save\";

        #endregion

        #region Fields

        private static readonly DirectoryInfo _saveDir = new DirectoryInfo(SAVE_DIRECTORY);

        #endregion

        #region Properties

        public static DirectoryInfo SaveDir
        {
            get
            {
                if (!_saveDir.Exists) _saveDir.Create();
                return _saveDir;
            }
        }

        #endregion
    }
}