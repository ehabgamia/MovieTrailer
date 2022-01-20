using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MovieTrailer.Models;
using MovieTrailer.PCL.Helper;

namespace MovieTrailer.PCL.Service
{
    public class AppUsersService
    {
        HttpClientHelper _helper;
        public AppUsersService()
        {
            _helper = new HttpClientHelper();
        }
        public async Task<ResultModel> GetLoginDetail(AppLoginModel model, string Url)
        {
            ResultModel resultModel = new ResultModel();
            try
            {
                resultModel = await _helper.Post<AppLoginModel>(model, Url);

                return resultModel;
            }
            catch (Exception ex)
            {
                // Crashes.TrackError(ex);
                return resultModel;
            }
        }

        public async Task<ResultModel> passwordReset(PasswordResetModel model, string Url)
        {
            ResultModel resultModel = new ResultModel();
            try
            {
                resultModel = await _helper.Post<PasswordResetModel>(model, Url);

                return resultModel;
            }
            catch (Exception ex)
            {
                // Crashes.TrackError(ex);
                return resultModel;
            }
        }
    }
}
