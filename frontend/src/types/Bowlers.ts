export type Bowlers = {
  bowlerID: number;
  bowlerFirstName: string;
  bowlerMiddleInit: string;
  bowlerLastName: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
  team: {
    teamID: number;
    teamName: string;
    captainID: number;
  };
};
