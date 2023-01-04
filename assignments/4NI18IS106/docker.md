# DevOps Assignment - 2
## 1.	Comparison between Hypervisor and Docker.

| Hypervisor | Docker |
| --- | --- |
| 1.   Works on software and hardware where it works on the operating system or on the CPU and storage services of the system.	| 1. Dockers work only on software of the operating system and not on the hardware side. It takes the host kernel and works on the principle of virtualization. |
| 2. In a single system, we can use multiple operating systems with the help of Hypervisor. This makes the system to work with multiple users with different methods even for the same program. Hence the same operation is done by different operating systems.	| 2. Docker does not allow user to create re instances of operating system in the same computer, it makes virtualization by making containers in the same system. Containers help users to work separately on different or same applications. same operations are carried out by containers in system. | 
| 3. More power and resources are required by the systems using hypervisor as different programs are being run on the same system with different operating systems.	| 3. Resource requirement is low as containers are working on the same operating system and this makes the system to share resources within the containers. |
| 4. Boot time is high for hypervisors as different operating systems are used. It may take some minutes to start the system and users can resume their work only after booting the machine. | 4. Boot time is low for dockers as all the containers work on the same machine. User can start the system in seconds and can start working on the same machine. |
| 5. We cannot test the same application with different parameters in hypervisor as there is no container method available. This application needs to be developed and tested in the system. If the parameters must be changed, it should be modified in the same operating system itself.	| 5. If the same application needs to be tested in the system with different instances, we can use containers as different parameters can be given to the application in the same container and can be tested at the same time. Dockers support this method of working which is called an agile model. |
| 6. Hypervisor works with host OS and guest OS which creates layers that run the hardware. We cannot create different instances for the same application in the system, but we can control the hardware and make the system work with both OS.	| 6.   Docker does not have an OS for itself and thus it creates instances and parameters by sitting on top of OS. This helps in modifying the instances if needed. It works solely on the host OS and does not control the hardware of the system. |
 


## 2.	Comparison between Containers and Virtual Machines.

| Containers	| Virtual Machines |
| --- | --- |
| 1.  A software that allows functionalities of an application independently.	| 1.  A software that allows you to install other software inside of it, so you basically control it virtually as opposed to installing the software directly on the computer. |
| 2. While applications running in a container environment share a single OS.	| 2. Applications running on VM system can run different OS. |
| 3. Virtualize the operating  system only.	| 3. virtualizes the computer system. |
| 4. the size of container is very light (in MBs)	| 4.  VM size is very large. |
| 5. While containers require very less memory.	| 5.  VM uses a lot of system memory. |
| 6. While containers are less secure.	| 6. VM is more secure. |
| 7. Useful when we are required to maximize, the running applications using minimal servers.	| 7. VM’s are useful when we require all of OS resources to run various applications. |
| 8. While examples of containers are: RancherOS, PhotonOS, Containers by Docker.	| 8. Examples of VM are: KVM, Xen, VMware. |

