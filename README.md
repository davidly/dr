# dr
Drives. Windows command line tool for showing information about your drives

Build with your favorite version of .net:

    c:\windows\microsoft.net\framework64\v4.0.30319\csc.exe /nowarn:0168 dr.cs
    
Usage: dr

    Enumerates hard drives
    bps = bytes per sector
    spc = sectors per cluster
    
Sample: 

    C:\>dr
    
              type     fs                           volume         total          free    bps    spc
     c:      fixed   ntfs                           c_boot    1,897,458m    1,346,399m    512      8
     d:      fixed   ntfs                       d_ssd_24tb   22,892,603m   15,395,333m    512     16
     e:  removable
     s:      fixed   ntfs                    s_ssd_4tb_pci    3,815,453m    3,645,809m    512      8
     w:    network   ntfs                        documents   28,486,662m   12,898,452m    512      2
     x:    network   ntfs                        documents   11,341,982m    4,487,213m    512      2
     y:      fixed   ntfs                        wd_12tb_d   11,444,093m    3,890,820m    512      8
     z:      fixed   ntfs                    z_4tb_ssd_far    3,815,453m    1,588,672m    512      8

