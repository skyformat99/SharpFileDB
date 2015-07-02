﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFileDB.Blocks
{
    /// <summary>
    /// 用于内存中的对象，便于把上下左右元素保存到数据库文件。
    /// </summary>
    public interface IFourSideLinked
    {

        /// <summary>
        /// 此对象的前一个对象在数据库文件中的位置。
        /// </summary>
        long LeftPos { get; set; }

        /// <summary>
        /// 此对象的前一个对象。
        /// </summary>
        IFourSideLinked LeftObj { get; set; }

        /// <summary>
        /// 此对象的后一个对象在数据库文件中的位置。
        /// </summary>
        long RightPos { get; set; }

        /// <summary>
        /// 此对象的后一个对象。
        /// </summary>
        IFourSideLinked RightObj { get; set; }

        /// <summary>
        /// 此对象的前一个对象在数据库文件中的位置。
        /// </summary>
        long UpPos { get; set; }

        /// <summary>
        /// 此对象的上一个对象。
        /// </summary>
        IFourSideLinked UpObj { get; set; }

        /// <summary>
        /// 此对象的后一个对象在数据库文件中的位置。
        /// </summary>
        long DownPos { get; set; }

        /// <summary>
        /// 此对象的下一个对象。
        /// </summary>
        IFourSideLinked DownObj { get; set; }
    }
}
