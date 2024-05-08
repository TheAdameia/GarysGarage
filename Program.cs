using Garage;
            
Zero fxs = new Zero
{
    MainColor = "Blue"
};
Tesla modelS = new Tesla
{
    MainColor = "Green"
};
Cessna mx410 = new Cessna
{
    MainColor = "White"
};

fxs.Drive();
fxs.Turn();
fxs.Stop();
modelS.Drive();
modelS.Turn();
modelS.Stop();
mx410.Drive();
mx410.Turn();
mx410.Stop();
