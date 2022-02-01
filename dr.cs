using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.Management;
using System.Runtime.InteropServices;

class Drives
{
    [DllImport("kernel32.dll", SetLastError=true, CharSet=CharSet.Auto)]
    static extern bool GetDiskFreeSpace( string lpRootPathName,
                                         out ulong lpSectorsPerCluster,
                                         out ulong lpBytesPerSector,
                                         out ulong lpNumberOfFreeClusters,
                                         out ulong lpTotalNumberOfClusters );

    static void Usage()
    {
        Console.WriteLine( "Usage: dr" );
        Console.WriteLine( "  Enumerates hard drives" );
        Console.WriteLine( "  bps = bytes per sector" );
        Console.WriteLine( "  spc = sectors per cluster" );

        Environment.Exit( 1 );
    }

    static void Main( string[] args )
    {
        try
        {
            if ( args.Length > 0 )
                Usage();

            Console.WriteLine( "          type     fs                           volume         total          free    bps    spc" );

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach ( DriveInfo d in drives )
            {
                Console.Write( " " + d.Name.Substring( 0, 2 ).ToLower() );
                Console.Write( "{0,11}", d.DriveType.ToString().ToLower() );

                if ( d.IsReady )
                {
                    Console.Write( "{0,7}", d.DriveFormat.ToLower() );
                    Console.Write( "{0,33}", d.VolumeLabel );
                    Console.Write( "{0,13:N0}m", d.TotalSize / ( 1024 * 1024 ) );
                    Console.Write( "{0,13:N0}m", d.AvailableFreeSpace / ( 1024 * 1024 ) );

                    ulong sectorsPerCluster, bytesPerSector, numberOfFreeClusters, totalNumberOfClusters;

                    if ( GetDiskFreeSpace( d.Name.Substring( 0, 2 ).ToLower(),
                                           out sectorsPerCluster,
                                           out bytesPerSector,
                                           out numberOfFreeClusters,
                                           out totalNumberOfClusters ) )
                    {
                        Console.Write( "{0,7:N0}", bytesPerSector );
                        Console.Write( "{0,7:N0}", sectorsPerCluster );
                    }
                }

                Console.WriteLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine( "dr caught an exception {0}", e.ToString() );
            Usage();
        }
    } //Main
} //Drives

