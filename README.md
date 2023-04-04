# dr
Drives. Windows command line tool for showing information about your drives

Build with your favorite version of .net:

    c:\windows\microsoft.net\framework64\v4.0.30319\csc.exe /nowarn:0168 dr.cs
    
Usage: dr

    Enumerates hard drives
    bps = bytes per sector
    spc = sectors per cluster
    
Sample: 

     D:\>dr
              type     fs                           volume         total          free    bps    spc
     c:      fixed   ntfs                           c_boot    1,897,458m    1,328,842m    512      8
     d:      fixed   ntfs                       d_ssd_24tb   22,892,603m   15,390,391m    512     16
     e:  removable  fat32                      OLY E-M10II        7,572m        4,493m    512     64
     f:  removable  fat32                          WALKMAN       12,554m       12,080m    512     64
     g:  removable  exfat                             flac      976,312m      492,560m    512  1,024
     h:      cdrom    udf                      Apr 03 2023       92,378m          781m  2,048      1
     i:      cdrom   cdfs                             ASUS          262m            0m  2,048      1
     s:      fixed   ntfs                    s_ssd_4tb_pci    3,815,453m    3,645,809m    512      8
     w:    network   ntfs                         pictures   11,341,982m    4,483,096m    512      2
     x:    network   ntfs                        documents   28,486,662m   12,449,504m    512      2
     y:      fixed   ntfs                  y_wd_12tb_dcopy   11,444,093m    3,885,597m    512      8
     z:      fixed   ntfs                    z_4tb_ssd_far    3,815,453m    1,586,422m    512      8
