select *, tripOdometer/gallons as MPG 
from MAINTENANCE join fuel on maintenance.tid = fuel.tid;


