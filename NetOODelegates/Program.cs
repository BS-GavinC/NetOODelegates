

using NetOODelegates;

Interrupteur interrupteur = new Interrupteur();

Lampe lampe1 = new Lampe("Lampe1");
Lampe lampe2 = new Lampe("Lampe2", interrupteur, Modes.fixe); 
Lampe lampe3 = new Lampe("Lampe3");
Lampe lampe4 = new Lampe("Lampe4", interrupteur, Modes.clignotte);
Lampe lampe5 = new Lampe("Lampe5", interrupteur, Modes.fixe);

interrupteur.Allumer();

interrupteur.Eteindre();
