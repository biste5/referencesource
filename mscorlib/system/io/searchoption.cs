// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*============================================================
**
** Enum:   SearchOption
** 
** <OWNER>[....]</OWNER>
**
**
** Purpose: Enum describing whether the search operation should  
** retrieve files/directories from the current directory alone  
** or should include all the subdirectories also.
**
**
===========================================================*/

using System;

namespace System.IO {
    [Serializable]
[System.Runtime.InteropServices.ComVisible(true)]
    public enum SearchOption
    {
        // Include only the current directory in the search operation
        TopDirectoryOnly,

        // Include the current directory and all the sub-directories
        // underneath it including reparse points in the search operation. 
        // This will traverse reparse points (i.e, mounted points and symbolic links)
        // recursively. If the directory structure searched contains a loop
        // because of hard links, the search operation will go on for ever. 
        AllDirectories,
    }
}
