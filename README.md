#### 4 Person project for a computer course I took at school

### ~90% of the backend simulation code was written by me.  (Found in sim_classes folder)
### Front end and test cases were not done by me.

### Simulation allows for variable number of warehouses, size and robots to be used.  Allows admin user to restock shelves and customer to place orders and view status.  
### Orders are placed to a pseudo server which then distributes tasks to each CPU in each warehouse which then co-ordinate robots to complete the tasks.  
### CPUs and robots are run in separate threads with a variety of queues, mutexes, tasks and signals to co-ordinate and synchronize them

### TO RUN THE SIMULATION:
### 1. Clone repo and run from IDE
### 2. Log in as admin (any valid string will work) and enter warehouse parameters.  Choose set warehouse when satisified
### 3. Return to the start page and click on run simulation.
### 4. The simulation is now started and there will be output on the console.  
### 5. The user can now log in as an admin again to place a restock request or log in as a user to place an order.
### 6. Clicking the refresh button on either the restocking page or order page will show current stock of items.
### 7. Orders are handled quickly, though not immediately, as there are sleep functions called in the methods in order to make the simulation more realistic.

