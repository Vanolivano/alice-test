﻿using alice.Models;

namespace alice.Extensions
{
    public static class Extensions
    {
        public static AliceResponse Reply(
          this AliceRequest req,
          string text,
          bool endSession = false,
          ButtonModel[] buttons = null) => new AliceResponse
          {
              Response = new ResponseModel
              {
                  Text = text,
                  Tts = text,
                  EndSession = endSession
              },
              Session = req.Session
          };
    }
}
